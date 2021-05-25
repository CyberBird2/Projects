function countdown (obj){

    var remainingcountdown =document.getElementById('Countnumber');


remainingcountdown.innerHTML=500-obj.value.length;

if(500-obj.value.length<=0){

    alert("To many characters limit is 500")
    document.getElementById("contact-message").disabled = true;
    remainingcountdown.innerHTML=0;

}

}