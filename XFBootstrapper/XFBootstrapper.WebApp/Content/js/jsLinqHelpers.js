Array.prototype.contains = function (searchObj) {
    return this.indexOf(searchObj) >= 0;
}

Array.prototype.first = function () {
    return this[0];
}

Array.prototype.last = function () {
    return this[this.length - 1];
}

// Intersection method, gets common elements between source array and a given array
Array.prototype.intersect = function (secondArray, comparisonFn) {
    var arrays = [];
    arrays.push(this);
    arrays.push(secondArray);
    var result = arrays.shift().reduce(function (res, v) {
        if (comparisonFn === undefined) {
            if (res.indexOf(v) === -1 && arrays.every(function (a) {
                return a.indexOf(v) !== -1;
            })) res.push(v);
        }
        else {
            res = comparisonFn(arrays, res, v);
        }
        return res;
    }, []);
    return result;
}

Array.prototype.insert = function (object, index) {
    this.splice(index, 0, object);
    return this;
}

Array.prototype.remove = function (object) {
    this.splice(this.indexOf(object), 1);
    return this;
}

Array.prototype.removeRange = function (arrayRange) {
    var src = this;
    $.each(arrayRange, function (index, item) {
        src.remove(item);
    });
    return src;
}
