/*

  GENERATE HEX TO ASCII SWITCH STATEMENT

*/

let hexToAscii = "switch(hex){ \n";

for (let i = 32; i <= 122; i++) {
  hexToAscii += `\tcase "${i.toString(
    16
  )}":\n\t\t return "${String.fromCharCode(i)}";\n`;
}

hexToAscii += `\tdefault:\n\t\t return "";\n}`;
console.log(hexToAscii);

/*

  GENERATE ASCII TO HEX SWITCH STATEMENT

*/

let asciiToHex = "switch(ascii){ \n";

for (let i = 32; i <= 122; i++) {
  let char = String.fromCharCode(i);

  asciiToHex += `\tcase "${char}":\n\t\t return "${i.toString(16)} ";\n`;
}

asciiToHex += `\tdefault:\n\t\t return "";\n}`;
console.log(asciiToHex);
