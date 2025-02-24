// let products = [];
// products[0] = "Iphone 12";
// products[1] = "Iphone 13";
// products[3] = "Iphone 13";
// products[5] = 4580;
// products[7] = true;
// products[9] = new Date();
// products[10] = "Iphone 13";

// console.log(products);

let students = ["ayşen", "umay", "ceyda", "begüm"];

let result;
result = students.length;
result = students;
result = students.toString();
result = students.join("-");
result = result.split("-");

let products1 = ["Ürün1", "Ürün2", "Ürün3"];
let products2 = ["Ürün4", "Ürün5"];

result = products1.concat(products2);

students.push("ahmet");//sona eleman ekler
students.unshift("murat");//başa eleman ekler
students.pop();//son elemanı siler
students.shift();//ilk elemanı siler

let index = students.indexOf("ceyda");
students[index] = "ceren";

let deleted = students.splice(index, 1);

result = students;

console.log(result);
console.log(deleted)