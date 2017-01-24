(function () {
    'use strict';

    var controllerId = 'users';

    angular.module('app').controller(controllerId, ['$routeParams', 'common', 'config', 'userFactory', users]);

    function users($routeParams, common, config, userFactory) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);
        var keyCodes = config.keyCodes;
        var vm = this;

        vm.users = [];
        vm.title = 'Users';
        vm.refresh = refresh;

        activate();

        function activate() {
            common.activateController([getUsers()], controllerId)
                .then(function () {
                    log('Activated User View');
                });
        }

        function getUsers() {
            vm.users = userFactory.init(4);
        }

        function refresh() {
            getUsers(true);
        }
    }
})();
