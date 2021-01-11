#include <iostream>
#include <fstream>
#include <string>
#include <chrono>
#include <conio.h>

using namespace std; using namespace chrono;

int amount;

void amountElement(string filename) {
    string line;

    ifstream in(filename);

    if (in.is_open()) {
        getline(in, line);
        in.close();
    }
    else cout << "incorrect";

    amount = stoi(line);
}

int* basic_array = new int[amount];

void fillFromFile(string filename) {
    string line; int i = 0;

    ifstream input(filename);

    if (input.is_open()) {
        while (getline(input, line)) {
            basic_array[i] = stoi(line);
            i++;
        }
        input.close();
    }
    else {
        cout << "Название файла введено неверно " << "( " << filename << " )" << endl;
    }
    input.close();
}

void shellSort(int *basic_array, int size) {
    auto start = steady_clock::now();

    int step, i, j, tmp;
    cout << "\n           ";
    for (int i = 0; i < size; i++)
        cout << basic_array[i] << " ";
    cout << "\n";

    for (step = size / 2; step > 0; step /= 2)
        for (i = step; i < size; i++)
            for (j = i - step; j >= 0 && basic_array[j] > basic_array[j + step]; j -= step)
            {
                tmp = basic_array[j];
                basic_array[j] = basic_array[j + step];
                basic_array[j + step] = tmp;
            }

    cout << "   ";
    cout << "Result: ";
    for (int i = 0; i < size; i++)
        cout << basic_array[i] << " ";

    auto end = steady_clock::now();

    auto resultTime = end - start;
    cout << "\n\nThe algorithm is executed in " << duration <double, milli>(resultTime).count() << " ms\n" << endl;
}

void fileOut(string filename) {
    ofstream out;

    out.open(filename);
    if (out.is_open()) {
        for (int i = 0; i < amount; i++) {
            out << basic_array[i] << endl;
        }
    }
}

int main()
{
    setlocale(0, "");
    string filename;

    cout << "Enter amount elements in array ( D:\\\\element\\element.dat ): "; cin >> filename;
    amountElement(filename);

    cout << "Enter filename for filling array: "; cin >> filename;
    fillFromFile(filename);

    shellSort(basic_array, amount);

    cout << "Enter filename for out array in file: "; cin >> filename;
    fileOut(filename);

    delete basic_array;
    system("pasue");
}

