var displayArray = function(array, firstIndex, secondIndex) {
    var x = 0, y = 0;
    var x1 = 0, x2 = 0, y1 = 0, y2 = 0;
    var xpad1 = 5, xpad2 = 5, ypad1 = 5, ypad2 = 15;
    
    textFont(createFont("monospace"), 12);
    fill(74, 11, 74);
    
    for(var i = 0; i < array.length; i++)
    {
        x = (i * 20) + 10;
        y = (firstIndex * 50) + 20;

        //output array
        text(array[i], x, y);
        
        //output lines
        if (i === secondIndex && firstIndex+1 !== array.length)
        {
            stroke(230, 129, 230);
            
            //line(x1, y1, x2, y2);
            //xy of indexofMinimum, xy of secondIndex
            x1 = x+xpad1;
            y1 = y+ypad1;
            x2 = ((firstIndex*20)+10)+xpad2;
            y2 = (((firstIndex+1)*50)+20)-ypad2;
            line(x1, y1, x2, y2);
        }
        
    }
};

var swap = function(array, firstIndex, secondIndex) {
    var temp = array[firstIndex];
    array[firstIndex] = array[secondIndex];
    array[secondIndex] = temp;
};

var indexOfMinimum = function(array, startIndex) {

    var minValue = array[startIndex];
    var minIndex = startIndex;

    for(var i = minIndex + 1; i < array.length; i++) {
        if(array[i] < minValue) {
            minIndex = i;
            minValue = array[i];
        }
    } 
    return minIndex;
}; 

var selectionSort = function(array) {
    var j = 0;
    for(var i = 0; i < array.length; i++) {
        j = indexOfMinimum(array, i);
        displayArray(array, i, j);
        swap(array, i, j);
    }
};

var array = [50, 2, 15, 4, 8,90, 22, 18];
array = selectionSort(array);
