angular.module('app').factory("countService", ['$resource',
    function ($resource) {
        var host = 'http://localhost/SLD.Service/api';

        var countPath = "/Count";

        return {
            getUsersByType: function () {
                return $resource(host + countPath, {}, {
                    query: {
                        method: 'GET',
                        isArray: false
                    }
                });
            }
        };
    }
]);