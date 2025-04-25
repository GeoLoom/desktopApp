#pragma once
#include <cmath>
#include <vector>

class Calculatrice {
public:
    int add(const int x[], int size);
    double racine(double x);
    long factoriel(long n);
    double puissance(double base, int exposant);
    std::vector<int> first(int n);
    int moyenne(const std::vector<int>& x);
};