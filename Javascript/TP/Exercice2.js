// Les Marques avec les actions
let VW = new Map()
let Mercedes = new Map()
let BMW = new Map()
let Audi = new Map()


VW.set("60000", "Vidange + Freins");
VW.set("120000", "Courroie");
VW.set("150000", "Vidange + Pneus");
VW.set("180000", "Filtre FAP");

Mercedes.set(40000, "Vidange");
Mercedes.set(90000, "Pneus + Freins");
Mercedes.set(120000, "Courroie");
Mercedes.set(170000, "Moteur");

BMW.set(30000, "Vidange");
BMW.set(120000, "Courroie");
BMW.set(190000, "Amortisseurs");
BMW.set(240000, "Voiture");

Audi.set(30000, "Vidange");
Audi.set(70000, "Courroie");
Audi.set(120000, "Pneus");
Audi.set(150000, "Freins");
Audi.set(250000, "Courroie")

// Affiche en colonne 
console.log("VW")
VW.forEach((value, key) => {
  console.log(`${key}: ${value}`)
})

console.log(" ")
console.log("Mercedes")
Mercedes.forEach((value, key) => {
  console.log(`${key}: ${value}`)
})
console.log(" ")
console.log("BMW")
BMW.forEach((value, key) => {
  console.log(`${key}: ${value}`)
})
console.log(" ")
console.log("Audi")
Audi.forEach((value, key) => {
  console.log(`${key}: ${value}`)
})

// Tableau
function plaquette() {
    const separateur = "|__________|_____________________|________________________|";
    
    afficheActions(separateur);
    afficheMarques(separateur)
}


function afficheActions(separateur) {
    const days = ["  Marques ", "Nombre de kilomètre ", "Réparations à réaliser"];
    let espace = "|"

    for (let column = 0; column < days.length; column++) {
        espace += `${days[column]}| `
    }
    console.log(separateur)
    console.log(espace)
    console.log(separateur)
}


function afficheMarques(separateur) {
    const VW = ["   VW   ", "Mercedes", "  BMW   ", "  Audi  "];
    let ligne = ""

    for (let column = 0; column < VW.length; column++) {
        ligne += `| ${VW[column]} |\n${separateur}\n`
    }
    console.log(ligne)
}

plaquette();