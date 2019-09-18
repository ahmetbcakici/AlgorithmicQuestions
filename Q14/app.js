

 var persons = ["Mehmet", "Ali", "Rıza","Orhan"]; 
 
 function combine_persons(array){
 
    for(var i = 0;i < array.length;i++){
       for(var j = i+1;j < array.length;j++){
          if(array[i] != array[j])
            console.log(array[i]+" , "+array[j]);
      }
   }
 }
 
 combine_persons(persons);
 

 
 