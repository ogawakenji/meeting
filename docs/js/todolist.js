var todoListModule = angular.module("TodoListModule", []);

todoListModule.value("Tasks", []);
todoListModule.value("DoneTasks", []);

todoListModule.controller("ShowTaskController", function ($rootScope, $scope, Tasks, DoneTasks) {

    $scope.tasks = Tasks;

    $scope.doneTask = function ($index) {
        Tasks[$index].done = true;
        DoneTasks.push($scope.tasks[$index].title);

        $rootScope.$broadcast('showDoneTasksEvent');
    }
});

todoListModule.controller("AddTaskController", function ($scope, Tasks) {

    $scope.addTask = function () {
        Tasks.push({ title: $scope.title, done: false });
        $scope.title = '';
    };
});

todoListModule.controller("ShowDoneTaskController", function ($scope, DoneTasks) {

    $scope.done_tasks = DoneTasks;

    $scope.$on('showDoneTasksEvent', function () {
        $scope.show_done_tasks = true;
    });
});