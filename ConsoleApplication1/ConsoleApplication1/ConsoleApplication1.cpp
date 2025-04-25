#include <iostream>
#include <cmath>
#include <vector>
#include <fstream>
#include "Calculatrice.h"



int main(int argc, char* argv[]) {
   
    if(argc > 0)
        switch(argv[1])
        {
            case '1':
            Calculatrice* calculatrice = new Calculatrice();


            int valeurs[] = { 1, 2, 3, 4, 5 };
            int size = sizeof(valeurs) / sizeof(valeurs[0]);
            std::cout << "Somme de ";
            for (int i = 0; i < size - 1; i++)
            {
                std::cout << valeurs[i] << "+";
            }
            std::cout << valeurs[size - 1] << " : " << calculatrice->add(valeurs, size) << std::endl;

            double num = 10.25;
            std::cout << "Racine carree de " << num << " : " << calculatrice->racine(num) << std::endl;

            long valeursfact = 5;
            std::cout << "Factoriel de" << valeursfact << " : " << calculatrice->factoriel(valeursfact) << std::endl;

            int limite = 50;
            std::vector<int> premiers = calculatrice->first(limite);
            std::cout << "Nombres premiers de " << limite << " : ";
            for (int p : premiers) {
                std::cout << p << " ";
            }
            std::cout << std::endl;

            double base = 2;
            int exp = 8;
            std::cout << base << "^" << exp << " = " << calculatrice->puissance(base, exp) << std::endl;

            std::vector<int> moyennevector = { 1, 2, 3, 4, 5 };
            std::cout << "Moyenne vector : "
                << calculatrice->moyenne(moyennevector)
                << std::endl;
            break;

            case '2':
                std::ofstream fichier;
                fichier.open("test.txt", std::ofstream::out | std::ofstream::app);
                fichier << " more lorem ipsum";

                fichier.close();
                break;

            default:
                break;
        }
    return 0;
}