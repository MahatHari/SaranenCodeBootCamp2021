let i = Math.floor(Math.random() * 20);
let j = 0;
let guess;
console.log(i);
do {
  guess = parseInt(prompt('Guess the Number'));
  if (guess === i) {
    alert('You guess it correct');
    break;
  } else {
    guess > i
      ? alert('Your guess is Greater than number')
      : alert('Your Guess is Less than number');
  }

  j++;
} while (j < 3);
