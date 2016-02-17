var app = angular.module('myApp', ['uiGmapgoogle-maps']);
app.controller('mapController', function ($scope, $http) {

    $scope.map = { center: { latitude: 28.028613, longitude: -82.595240 }, zoom: 16 }

    $scope.markers = [];
    $scope.locations = [];


    $http.get('/home/GetAllLocation').then(function (data) {
        $scope.locations = data.data;
    }, function () {
        alert('Error');
    });

    $scope.ShowLocation = function (locationID) {
        $http.get('/home/GetMarkerInfo', {
            params: {
                locationID: locationID
            }
        }).then(function (data) {

            $scope.markers = [];
            $scope.markers.push({
                id: data.data.LocationID,
                coords: { latitude: data.data.Lat, longitude: data.data.Long },
                title: data.data.title,
                address: data.data.Address,
                image: data.data.ImagePath
            });

            $scope.map.center.latitude = data.data.Lat;
            $scope.map.center.longitude = data.data.Long;

        }, function () {
            alert('Error');
        });
    }

    $scope.windowOptions = {
        show: true
    };

});