﻿/// <reference path="Scripts/ui-bootstrap-tpls-0.11.0.js" />
/// <reference path="Scripts/ui-bootstrap-tpls-0.11.0.js" />
/// <reference path="Scripts/ui-bootstrap-tpls-0.11.0.js" />
require.config({

    baseUrl: "",
    // alias libraries paths
    paths: {
        'application-configuration': 'application-configuration',
        'angular': 'lib/angular/angular',
        'angular-route': 'lib/angular-route/angular-route',
        'angularAMD': 'lib/angularAMD/angularAMD',
        'ui-bootstrap': 'lib/angular-ui-bootstrap-bower/ui-bootstrap-tpls',
        'blockUI': 'lib/angular-block-ui/dist/angular-block-ui',
        'ngload': 'lib/custom/ngload',
        'angular-sanitize': 'lib/angular-sanitize/angular-sanitize',

    },

    // Add angular modules that does not support AMD out of the box, put it in a shim
    shim: {
        "angular": { exports: "angular" },
        'angularAMD': ['angular'],
        'angular-route': ['angular'],
        'blockUI': ['angular'],
        'angular-sanitize': ['angular'],
        'ui-bootstrap': ['angular']

    },

    // kick start application
    deps: ['application-configuration']
});
