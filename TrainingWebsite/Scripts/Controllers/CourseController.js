var CourseController = function ($scope, courses) {
    debugger;
    courses.success(function (data) {
        debugger;
        $scope.details = data;
    });
   
}
CourseController.$inject = ['$scope', 'courses'];
trainingHouseApp.controller('CourseController', CourseController);