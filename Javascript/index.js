//const fs = require('fs');
import { fs } from 'fs';
let file = fs.readFileSync('../num.txt', 'utf-8');
let dataArray = file.split(/\r\n/);

const sum = dataArray.reduce((acc, init) => (acc += +init), 0);
console.log(sum);
