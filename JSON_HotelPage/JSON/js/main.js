
/*Example 1 - 2 */

//var xhr = new XMLHttpRequest();
//xhr.open('GET', "data.json", true);
//xhr.responseType = 'text';
//xhr.send();

//xhr.onload = function () {
//    if (xhr.status === 200) {       
//        var myStuff = JSON.parse(xhr.responseText);
//        console.log(myStuff);

//        for (var i = 0; i < myStuff.presidents.length; i++) {
//            console.log(myStuff.presidents[i].first);
//            console.log(myStuff.presidents[i].last);
//            console.log(myStuff.presidents[i].served);

//            console.log(myStuff.vicepresidents[i].first);
//            console.log(myStuff.vicepresidents[i].last);
//        }

//        var myString = "";
//        for (var i = 0; i < myStuff.presidents.length; i++) {

//            var x = i + 1;
//            myString += "<br>President " + x + " was ";
//            myString += myStuff.presidents[i].first + " ";
//            myString += myStuff.presidents[i].last + " ";

//            myString += "He served form " + myStuff.presidents[i].served + " with ";
//            myString += myStuff.vicepresidents[i].first + " ";
//            myString += myStuff.vicepresidents[i].last + " ";
//        }

//        document.getElementById('message').innerHTML = myString;
//    }
//}



// JavaScript Document
var hotelInfo;
var details;
var xhr = new XMLHttpRequest();
xhr.open('GET', "data.json", true);
xhr.responseType = 'text';
xhr.send();


xhr.onload = function () {
    if (xhr.status === 200) {
        hotelInfo = JSON.parse(xhr.responseText);
        console.log(hotelInfo);
        display(0);

    } // end if
} // end function


function display(x) {
    console.log(x);
    document.getElementById('roomName').innerHTML = hotelInfo[x].name;
    document.getElementById('desc').innerHTML = hotelInfo[x].description;
    document.getElementById('photo').src = hotelInfo[x].photo;
    document.getElementById('weekday').innerHTML = hotelInfo[x].cost.weekday;
    document.getElementById('weekend').innerHTML = hotelInfo[x].cost.weekend;

    
    details = "";
    for (var i = 0; i < hotelInfo[x].details.length; i++) {
        details += "<p>" + hotelInfo[x].details[i] + "</p>";
    }

    document.getElementById('details').innerHTML = details;

}


