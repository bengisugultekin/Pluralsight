// JavaScript Document

//var start = '{"favColor":"Purple", "favSeason":"Spring"}';

//var myObject = JSON.parse(start);
//console.log(myObject);

//var myString = JSON.stringify(myObject);
//console.log(myString);

//var myObject = JSON.parse(myString);
//console.log(myObject);






//var theData1 = '{"first":"Paul","last":"Cheney","city":"Salem"}';
//var myObj = JSON.parse(theData1);
////console.log(myObj);

//document.getElementById('message').innerHTML = myObj.city;




//var theData2 = '{"Jane":{"age":"29", "degree":{"AAS":"VMI", "BA":"UVA"}}, "Jim":{"age":"49", "degree":"MA"}}';
//var myObj = JSON.parse(theData2);
//console.log(myObj);

//document.getElementById('message').innerHTML = myObj.Jane.degree.BA;





var xhr = new XMLHttpRequest();

xhr.open('GET', 'data.json', true);
xhr.responseText = 'text';

//xhr.onreadystatechange = function () {
//    console.log(xhr.readyState);
//    console.log(xhr.status);
//    console.log(xhr.statusText);
//}

xhr.onload = function () {
    if (xhr.status === 200) {
        var myStuff = JSON.parse(xhr.responseText);
        console.log(myStuff);
    }    
}

xhr.send();
