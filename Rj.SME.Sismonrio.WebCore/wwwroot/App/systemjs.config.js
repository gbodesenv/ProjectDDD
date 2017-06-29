﻿(function (global) {
    System.config({
        paths: {
            // paths serve as alias
            'npm:': '/Node_Modules/'
        },

        // map tells the System loader where to look for things
        map: {
            // our app is within the app folder
            app: '../../App',

            // angular bundles
            '@angular/core': 'npm:@angular/core/bundles/core.umd.js',
            '@angular/common': 'npm:@angular/common/bundles/common.umd.js',
            '@angular/compiler': 'npm:@angular/compiler/bundles/compiler.umd.js',
            '@angular/platform-browser': 'npm:@angular/platform-browser/bundles/platform-browser.umd.js',
            '@angular/platform-browser-dynamic': 'npm:@angular/platform-browser-dynamic/bundles/platform-browser-dynamic.umd.js',
            '@angular/http': 'npm:@angular/http/bundles/http.umd.js',
            '@angular/router': 'npm:@angular/router/bundles/router.umd.js',
            '@angular/forms': 'npm:@angular/forms/bundles/forms.umd.js',

            // other libraries
            'rxjs': 'npm:rxjs',
        },

        // packages tells the System loader how to load when no filename and/or no extension
        packages: {
            app: {
                main: './main.js',
                defaultExtension: 'js'
            },
            meta: {
                './*.js': {
                    loader: 'systemjs-angular-loader.js'
                }
            },
            rxjs: {
                defaultExtension: 'js'
            }
        }
    });

    global.bootstrapping = System
        .import("app")
        .then(
        function handleResolve() {

            console.info("System.js successfully bootstrapped app.");

        },
        function handleReject(error) {

            console.warn("System.js could not bootstrap the app.");
            console.error(error);

            return (Promise.reject(error));

        }
        );
})(this);