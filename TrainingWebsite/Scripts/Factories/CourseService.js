trainingHouseApp.factory('courses', ['$http', function ($http) {
    debugger;
    return $http.get('api/Course/')
           .success(function (data) {
               debugger;
               return data;
           })
           .error(function (data) {
               return data;
           });
}]);
