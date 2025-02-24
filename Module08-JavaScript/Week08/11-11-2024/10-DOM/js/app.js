// DOM-Document Object Model

// 1) Single Element

// let result;
// result = document.getElementById("task-list");
// result = document.querySelector("#task-list");
// result.style.backgroundColor = "blue";
// result.style.color = "white";


// const baslik = document.getElementById("page-title");
// baslik.style.color = "green";
// baslik.style.backgroundColor = "yellow";
// baslik.style.fontFamily = "Tahoma";
// baslik.style.padding = "15px";


// console.log(result);


// const taskItem = document.querySelector("#task-list-2 .task-item");
// console.log(taskItem);

// 2) MULTI ELEMENTS

// let result;

// result = document.getElementsByClassName("card-title");
// result = document.getElementsByClassName("task-item");

// result = document.getElementsByTagName("div");
// result = document.getElementsByTagName("ul");

// result = document.querySelectorAll(".task-item");
// result = document.querySelectorAll("div");

// console.log(result);

//ÖDEV: HtmlCollection ile NodeList arasındaki farkları/benzerlikleri araştırın.

// 3) TRAVERSING
let result;

// const taskList = document.getElementById("task-list");
// result = taskList.children;

// const cardHeader = document.querySelector(".card-header");
// result = cardHeader.children;

// const body = document.querySelector("body");
// result = body.children;

//const taskList = document.getElementById("task-list");
// result = taskList.firstElementChild;
// result = taskList.lastElementChild;
// result = taskList.firstChild;

// result = taskList.children[2];

// result = result.parentElement.parentElement;

const firstTask = document.getElementById("task-list").firstElementChild;
result = firstTask.previousElementSibling;


// result = firstTask.textContent;
// result = firstTask.nextElementSibling.nextElementSibling;
// result = result.previousElementSibling.textContent;


const lastTask = document.getElementById("task-list").lastElementChild;
result = lastTask.nextElementSibling;
console.log(result);

