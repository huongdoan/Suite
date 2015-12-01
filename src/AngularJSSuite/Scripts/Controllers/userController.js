(function () {
    'use strict';
    angular
        .module('AngularSuiteApp')
        .controller('userController', userController);

    userController.$inject = ['$scope','User']; 

    function userController($scope, User) {
        $scope.title = 'userController';
        $scope.Users = User.query();
        console.log($scope.Users);
    }
})();
