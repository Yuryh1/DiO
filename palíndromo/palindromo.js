function verifcapalindromo(string) {
    if(!string) return;

    return string.split("").reverse().join("") === string;
}

console.log(verifcapalindromo("ovo"))