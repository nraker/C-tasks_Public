#include <iostream>
#include <string>
#include <fstream>

using namespace std;

int countArr() {
    string line, filename;
    setlocale(0, "");

    cout << "Введите название файла с количеством элементов: "; cin >> filename; system("cls");

    ifstream input(filename);

    if (input.is_open())
        getline(input, line);
    else cout << "Название файла введено неверно " << "( " << filename << " )" << endl;
    input.close();
    return stoi(line);
}

int countArray = countArr();
int* Array = new int();

void input_array(string filename) {
    string line; int i = 0;

    ifstream input(filename);

    if (input.is_open()) {
        while (getline(input, line)) {
            Array[i] = stoi(line);
            i++;
        }
        input.close();
    }
    else {
        cout << "Название файла введено неверно " << "( " << filename << " )" << endl;
    }
    input.close();
}

void shekerSort(int* array, int count)
{
    int left = 0, right = count - 1; // левая и правая границы сортируемой области массива
    int flag = 1;  // флаг наличия перемещений
    // Выполнение цикла пока левая граница не сомкнётся с правой
    // и пока в массиве имеются перемещения
    while ((left < right) && flag > 0)
    {
        flag = 0;
        for (int i = left; i < right; i++)  
        {
            if (Array[i] > Array[i + 1]) 
            {             
                double t = Array[i];
                Array[i] = Array[i + 1];
                Array[i + 1] = t;
                flag = 1;     
            }
        }
        right--;
        for (int i = right; i > left; i--) 
        {
            if (Array[i - 1] > Array[i]) 
            {          
                int t = Array[i];
                Array[i] = Array[i - 1];
                Array[i - 1] = t;
                flag = 1;    
            }
        }
        left++; 
    }
}

void fileout(string filename) {
    ofstream output;

    output.open(filename);
    if (output.is_open()) {
        for (int i = 0; i < countArray; i++) {
            output << Array[i] << endl;
        }
    }
    else cout << "Название файла введено неверно " << "( " << filename << " )" << endl;
}

int main()
{
    string filename;

        cout << "Введите название файла с элементами: "; cin >> filename; system("cls");
        input_array(filename);


    shekerSort(Array, countArray);

    cout << "\n\nВведите название файла для вывода: "; cin >> filename; system("cls");
    if (filename == "esc") {
        exit(0);
    }
    fileout(filename);

    delete Array;
    system("pause");
}
