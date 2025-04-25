#include "Calculatrice.h"

int Calculatrice::add(const int x[], int size) {
    int result = 0;
    for (int i = 0; i < size; i++) {
        result += x[i];
    }
    return result;
}

double Calculatrice::racine(double x) {
    return std::sqrt(x);
}

long Calculatrice::factoriel(long n) {
    return n > 1 ? (n * factoriel(n - 1)) : 1;
}

double Calculatrice::puissance(double base, int exposant) {
    return std::pow(base, exposant);
}

std::vector<int> Calculatrice::first(int n) {
    std::vector<int> nombresPremiers;
    for (int num = 2; num <= n; num++) {
        bool estPremier = true;
        for (int i = 2; i <= std::sqrt(num); i++) {
            if (num % i == 0) {
                estPremier = false;
                break;
            }
        }
        if (estPremier) {
            nombresPremiers.push_back(num);
        }
    }
    return nombresPremiers;
}

int Calculatrice::moyenne(const std::vector<int>& x) {
    int result = 0;
    for (int num : x) {
        result += num;
    }
    return x.empty() ? 0 : result / x.size();
}
