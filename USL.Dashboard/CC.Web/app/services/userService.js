angular.module('app').factory("userService", ['$resource',
    function ($resource) {
        var host = 'http://localhost/SLD.Service/api';

        var userPath = "/User";

        return {
            getUsersByType: function () {
                return $resource(host + userPath, {}, {
                    query: {
                        method: 'GET',
                        isArray: true,
                        params: {
                            userTypeId: '@userTypeId'
                        }
                    }
                });
            }
        };
    }
]);