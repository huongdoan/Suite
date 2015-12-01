(function () {
    'use strict';
    var userService = angular.module('userService', ['ngResource']);

    userService.factory('User', User);

    User.$inject = ['$resource'];

    function User($resource) {
        return $resource('/api/user', {}, {
            query: { method: 'GET', params: {}, isArray: true }
        });
        //var service = {
        //    getData: getData($resource)
        //};

        //return service;

        //function getData($resource) {
        //    return $resource('/api/user', {}, {
        //        query: { method: 'GET', params: {}, isArray: true }
        //    });
        //}
    }
})();