// ****** STRING ******

// let title = "String Functions";
// console.log("Başlık: " + title);
// console.log("Uzunluk: " + title.length);
// console.log("Başlık'ın 3.Karakteri: " + title.charAt(2));
// console.log("BAŞLIK: " + title.toUpperCase());
// console.log("başlık: " + title.toLowerCase());
// console.log("Başlık'ın ilk 6 karakteri: " + title.slice(0, 6));
// console.log("Başlık'ın 8.Karakterinden sonrası: " + title.slice(7));
// console.log("Yerine koy: " + title.replace("n", "N"));
// let message = "          Merhaba            ";
// console.log("Trim Left: " + message.trimStart());
// console.log("Trim Right: " + message.trimEnd());
// console.log("Trim: " + message.trim());
// console.log("g harfi kaçıncı sırada?: " + title.indexOf("-"));
// console.log("S harfi ile başlıyor mu?: " + title.startsWith("St"));
// console.log("S harfi ile bitiyor mu?: " + title.endsWith("s"));

// let title = "Başakşehir Futbol Kulübü Tur Atladı";
// //Başakşehir
// //Futbol
// //Kulübü
// //Tur
// //Atladı
// title = title.toLowerCase();
// let titleArray = title.split(" ");
// let titleResult = titleArray.join("-");
// console.log(titleResult);

// ****** NUMBER ******
// let result;

// result = parseInt(10.78);
// result = parseInt("10.78");
// result = parseInt("         10dsa.assf78asdf");
// result = parseFloat("10.78.45sdafaf");

// let number = 10.387459;
// result = number.toFixed(4);
// result = number.toPrecision(6);

// result = Math.round(2.4);
// result = Math.round(2.5);
// result = Math.ceil(2.1);
// result = Math.floor(2.9);

// result = Math.pow(5, 2);
// result = Math.pow(5, 5);
// result = Math.sqrt(25);
// result = Math.abs(-40);

// result = Math.min(45, 56, 7, 39, 124);
// result = Math.max(45, 56, 7, 39, 124);

// result = Math.random();
// result = parseInt(Math.random() * 100) + 1;


// console.log(result);


// ****** DATE ******

let result;
let now;

now = new Date();
// result = now;

// result = now.getDate();
// result = now.getMonth();
// result = now.getDay();
// result = now.getFullYear();
// result = now.getHours();
// result = now.getTime();

let birthDate = new Date(1975, 6, 16);

let year = birthDate.getFullYear(); //1975
let month = birthDate.getMonth(); //6
let day = birthDate.getDate();//16
result = "Sen " + year + " yılının " + (month + 1) + ".ayının " + day + ".gününde doğmuşsun.";
console.log(result);