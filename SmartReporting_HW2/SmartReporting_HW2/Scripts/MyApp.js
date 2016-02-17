(function () {
    //Module I
    var app = angular.module('MyApp', ['ngRoute']);

    //Controller I
    app.controller('HomeController', function ($scope) {
        $scope.Message = "Yes, I finally get AngularJS working in my HW2.";
    });
}
)();