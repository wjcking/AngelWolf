﻿
String.prototype.upperFirst = function  () {
     return this.substring(0, 1).toUpperCase() + this.substring(1);
}
String.prototype.lowerFirst = function  () {
     return this.substring(0, 1).toUpperCase() + this.substring(1);
}
String.prototype.replaceAll=    function(s2, replacement) {
    return this.replace(new RegExp(s2, 'g'), replacement);
}
String.prototype.format = function () {
    if (arguments.length == 0) {
        return this;
    }
    for (var s = this, i = 0; i < arguments.length; i++) {
        s = s.replace(new RegExp("\\{" + i + "\\}", "g"), arguments[i]);
    }
    return s;
};
String.prototype.extent = {
    index: 0,
    start =0,
    end =0,
    color: function (param) {

    }
}

};
