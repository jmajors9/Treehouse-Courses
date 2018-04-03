require("babel-polyfill");

function doubleAsync (value) {
  return new Promise((resolve, reject) => {
    setTimeout(() => resolve(value * 2), 3000);
  })
}

async function myAsyncFunction () {
  var answer = await doubleAsync(1337);
  console.log(answer);
}

myAsyncFunction();
 
