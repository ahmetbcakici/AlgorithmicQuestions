
let arr = ['a', 'b', 'c', 'd', 'e']
let numbers = ['1','2','3','4','5','6']

function revert2nd(array){
  for(var i = 0;i < array.length;i++){
    if(i % 2 == 1){
      var temp = array[i-1];
      array[i-1] = array[i];
      array[i] = temp;
     }
  }
  for(var x of array) console.log(x);
}

revert2nd(arr);
revert2nd(numbers);

