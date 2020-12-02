function multiplication(param1, param2) {
    return param1 + " * " + param2 + " = " + param1*param2;
}

function division(param1, param2) {
    return param1 + " / " + param2 + " = " + param1/param2;
}

function addition(param1, param2) {
    return param1 + " + " + param2 + " = " + (param1+param2);
}

function soustraction(param1, param2) {
    return param1 + " - " + param2 + " = " + (param1-param2);
}

function fonctionMere(operateur, param1, param2){
    if (operateur == "*"){
        console.log(multiplication(param1,param2));
    }
    else if (operateur == "/") {
        console.log(division(param1,param2));
    }
    else if (operateur == "+") {
        console.log(addition(param1,param2));
    }
    else if (operateur == "-") {
        console.log(soustraction(param1,param2));
    }
    else {
        console.log("erreur")
    }
}

function tablesMultiplications(){
    for (let i = 0; i < 11; i++) {
        console.log(" ");
        console.log("Table de Multiplication : " + i);
        console.log(" ");
        for (let i2 = 0; i2 < 11; i2++) {
            console.log(multiplication(i2, i))
        }
    }
    
}

tablesMultiplications();
fonctionMere("-", 6, 6);