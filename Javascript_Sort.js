// cerner_2^5_2020
// JavaScript to illustrate sort() function 
<script> 
function func() { 
    // Original array 
    var arr = [2, 5, 8, 1, 4]; 
  
    document.write(arr.sort(function(a, b) { 
    return a + 2 * b; 
})); 
document.write("<br>"); 
document.write(arr); 
} 
func(); 
</script> 