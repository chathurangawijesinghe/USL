(function () {
    'use strict';

    var controllerId = 'definers';

    angular.module('app').controller(controllerId, ['$routeParams', 'common', 'config', 'userFactory', definers]);

    function definers($routeParams, common, config, userFactory) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);
        var keyCodes = config.keyCodes;
        var vm = this;

        vm.definers = [];
        vm.title = 'Definers';
        vm.refresh = refresh;

        activate();

        function activate() {
            common.activateController([getDefiners()], controllerId)
                .then(function () {
                    log('Activated Definer View');
                });
        }

        function getDefiners() {
            vm.definers = userFactory.init(3);
        }

        function refresh() {
            getDefiners(true);
        }
    }
})();
