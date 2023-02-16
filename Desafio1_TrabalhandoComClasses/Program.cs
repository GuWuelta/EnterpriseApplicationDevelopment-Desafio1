// See https://aka.ms/new-console-template for more information

using Desafio1_TrabalhandoComClasses.Classes;

// tentativa com sucesso
Pokemon pokemonObj = Pokemon.createPokemon("Ash", "Pikachu", "Electric", "Thunderbolt!");

string pokemonTrainer = pokemonObj.Trainer;
string pokemonName = pokemonObj.Name;
string pokemonType = pokemonObj.Type;
string pokemonAttack = pokemonObj.Attack;

Console.WriteLine("WHO'S THAT POKEMON!? \n");
Console.WriteLine($"Trainer: {pokemonTrainer} \nName: {pokemonName} \nType: {pokemonType} \nAttack: {pokemonAttack}");

