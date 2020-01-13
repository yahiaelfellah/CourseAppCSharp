/// <binding Clean='clean' />
"use strict";

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify");

var root_path  =  {
    webroot:  "./wwwroot/"
};
//library source
root_path.nmSrc  =  "./node_modules/";
//library destination
root_path.package_lib  =  root_path.webroot  +  "lib-npm/";

var paths = {
    js:   root_path.webroot + "js/**/*.js",
    minJs:   root_path.webroot + "js/**/*.min.js",
    css:   root_path.webroot + "css/**/*.css",
    minCss:   root_path.webroot + "css/**/*.min.css",
    concatJsDest:   root_path.webroot + "js/site.min.js",
    concatCssDest:   root_path.webroot + "css/site.min.css"
};

gulp.task("clean:js", function (cb) {
    rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);

gulp.task("min:js", function () {
    return gulp.src([paths.js, "!" + paths.minJs], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    return gulp.src([paths.css, "!" + paths.minCss])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "min:css"]);


gulp.task('copy:libs', () => {
    gulp.src([
            'core-js/client/**',
            'systemjs/dist/system.src.js',
            'reflect-metadata/**',
            'rxjs/**',
            'zone.js/dist/**',
            '@angular/**',
            '@types/**'
        ], {
            cwd: 'node_modules//**'
        })
        .pipe(gulp.dest('./wwwroot/'));
});

gulp.task("copy-systemjs",  function ()  {
        return  gulp.src(root_path.nmSrc  +  '/systemjs/dist/**/*.*',  {
        base:  root_path.nmSrc  +  '/systemjs/dist/'
    }).pipe(gulp.dest(root_path.package_lib  +  '/systemjs/'));
});
gulp.task("copy-angular2",  function ()  {
    return gulp.src(root_path.nmSrc +  '/@angular/**/*.*',  {
        base: root_path.nmSrc +  '/@angular/**/*.*'
    }).pipe(gulp.dest(root_path.package_lib +  '/@angular/**/*.*'));
});
gulp.task("copy-es6-shim",  function ()  {
        return  gulp.src(root_path.nmSrc  +  '/es6-shim/es6-sh*',  {
        base:  root_path.nmSrc  +  '/es6-shim/'
    }).pipe(gulp.dest(root_path.package_lib  +  '/es6-shim/'));
});
gulp.task("copy-rxjs",  function ()  {
        return  gulp.src(root_path.nmSrc  +  '/rxjs/bundles/*.*',  {
        base:  root_path.nmSrc  +  '/rxjs/bundles/'
    }).pipe(gulp.dest(root_path.package_lib  +  '/rxjs/'));
});
gulp.task("copy-all",  ["copy-rxjs",  'copy-angular2',  'copy-systemjs',  'copy-es6-shim']);

