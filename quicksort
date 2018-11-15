// Swaps two items in an array, changing the original array
var swap = function(array, firstIndex, secondIndex) {
    var temp = array[firstIndex];
    array[firstIndex] = array[secondIndex];
    array[secondIndex] = temp;
};

// This function partitions given array and returns 
//  the index of the pivot.
var partition=function(array, p, r){
    var q=p;
    for (var j=p;j<r;j++) {
        if (array[j] <= array[r]) {
            swap(array, j, q);q++;
        }
    }
    swap(array, r, q);
    return q;
};


var quickSort = function(array, p, r) {
    if (p < r) {
        var pivot = partition(array, p, r);
        quickSort(array, p, pivot-1);
        quickSort(array, pivot+1, r);
    }
};

var array = [9, 7, 5, 11, 12, 2, 14, 3, 10, 6];
quickSort(array, 0, array.length-1);
println("Array after sorting: " + array);
Program.assertEqual(array, [2,3,5,6,7,9,10,11,12,14]);

array = [9, 7, 5, 11, 12, -2, 14, 3, 10, 6];
quickSort(array, 0, array.length-1);
println("Array after sorting: " + array);
Program.assertEqual(array, [-2,3,5,6,7,9,10,11,12,14]);

