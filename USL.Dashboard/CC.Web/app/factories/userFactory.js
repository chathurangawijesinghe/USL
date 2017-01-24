angular.module('app').factory('userFactory', ["userService",
    function (userService) {
        var factory = {};
        factory.data = [];

        function loadUsers(userTypeId) {
            var usersData = userService.getUsersByType();
            usersData.query({
                userTypeId: userTypeId,
            }).$promise.then(function (response) {
                factory.data = response;
            }, function (error) {
                alert(error);
            });
        }

        return {
            init: function (userTypeId) {
                loadUsers(userTypeId);
                return factory;
            }
        };
    }]);