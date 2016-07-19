//AngularJS
var myApp = angular.module('myApp', []);

myApp.factory('ProfileService', ['$http', function ($http) {

    var ProfileService = {};
    ProfileService.getProfile = function () {
        //  return $http.get('/profile/login');
        var request = $http({
            method: 'get',
            url: '/api/chatterservice'
        });
        return request;
    };
    return ProfileService;

}]);


myApp.controller("ProfileController", function ($scope, ProfileService, $http) {

    $scope.Groups = [{
        name: 'Johnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn',
        member: '5',
        link: 'https://google.com'
    }, {
        name: 'Frank',
        member: '10',
        link: 'https://google.com'
    }, {
        name: 'Sue',
        member: '15',
        link: 'https://google.com'
    }];


    //$http.get('/api/chatterservice')
    //.then(function (response) {
    //    $scope.myWelcome = response.data;
    //});

    $scope.getProfile = function () {
        $http.get('/api/profileservice')
    .then(function (response) {
        $scope.myWelcome = response.data;
    });
    }

    //$scope.getProfile = function () {
    //    ProfileService.getProfile()
    //        .success($scope.status = "Success")
    //        .error(function (error) {
    //            $scope.status = 'Unable to load customer data: ' + error.message;
    //            console.log($scope.status);
    //        });
    //}



});


