(function () {
    'use strict';

    angular
        .module('AngularSuiteApp')
        .controller('loginController', loginController);

    loginController.$inject = ['$rootScope', '$scope', '$location', '$window', 'AuthService'];

    function loginController($rootScope, $scope, $location, $window, AuthService) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'loginController';
        $scope.rememberme = true;
        $scope.login = function () {
            Auth.login({
                username: $scope.username,
                password: $scope.password,
                rememberme: $scope.rememberme
            },
                function (res) {
                    $location.path('/');
                },
                function (err) {
                    $rootScope.error = "Failed to login";
                });
        };

        $scope.loginOauth = function (provider) {
            $window.location.href = '/auth/' + provider;
        };
    }
})();
