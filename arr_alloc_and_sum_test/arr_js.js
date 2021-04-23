//let a = new Array(20000000);
let a = [];

for (let i = 0; i < 20000000; i++){
    a.push(i);
    //a[i] = i;
}

let len = a.length;
let sum  = 0;

console.time("time");

for (let i = 0; i < len; i++){
    sum+=a[i]
}

console.timeEnd("time")

console.log(sum)