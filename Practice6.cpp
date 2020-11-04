

#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");

    int Tnum, array[100], i = 0, count = 0, min = 1000, max = 0, mArray[100][100], j, countI, countJ, matrix, maxStr;
    double rMax = 0, rArray[100], ar, sum = 0;

    cout << "Выберите задание от 1 до 10" << endl;
    cin >> Tnum;
    system("cls");
    switch (Tnum) {
    case 1:
        for (i = 0; i < 5; i++) {
            cout << "Вы вводите элемент массива с номером " << i << endl;
            cin >> array[i];

            if (array[i] != 0) {
                count++;
            }
        }
        system("cls");
        cout << "Количество ненулевых элементов: " << count << endl;
        break;
    case 2:
        for (i = 0; i < 6; i++) {
            cout << "Вы вводите элемент массива с номером " << i << endl;
            cin >> array[i];


            if (array[i] < min) {
                min = array[i];
            }
        }
        system("cls");
        cout << "Минимальное число: " << min << endl;
        break;
    case 3:
        cout << "Введите количество элементов" << endl;
        cin >> count;

        for (i = 0; i < count; i++) {
            cin >> rArray[i];
            if (rArray[i] > rMax) {
                rMax = rArray[i];
            }
        }

        system("cls");
        cout << "Максимальное число: " << rMax << endl;
        break;

    case 4:
        cout << "Введите количество элементов" << endl;
        cin >> count;

        for (i = 0; i < count; i++) {
            cin >> array[i];
            if (array[i] < min) {
                min = array[i];
            }
        }

        system("cls");
        cout << "Минимальное число: " << min << endl;
        break;

    case 5:
        cout << "Введите количество элементов" << endl;
        cin >> count;

        for (i = 0; i < count; i++) {
            cin >> rArray[i];
            if (rArray[i] > rMax) {
                rMax = rArray[i];
            }
        }

        system("cls");
        cout << "Максимальное число: " << rMax << endl;
        break;

    case 6:
        cout << "Введите размер массива" << endl;;
        cin >> i >> j;

        for (countI = 0; countI < i; countI++) {
            for (countJ = 0; countJ < j; countJ++) {
                cin >> mArray[countI][countJ];
            }
        }

        system("cls");

        for (countI = 0; countI < i; countI++) {
            for (countJ = 0; countJ < j; countJ++) {
                cout << "" << mArray[countI][countJ] << " ";
            }
            cout << endl;
        }

        cout << endl;
        for (countJ = 0; countJ < j; countJ++) {
            for (countI = 0; countI < i; countI++) {
                sum += mArray[countI][countJ];
            }
            cout << "Сумма " << countJ + 1 << " столбца: " << sum << endl;;
            sum = 0;
        }
        break;

    case 7:
        cout << "Введите размер массива" << endl;;
        cin >> i >> j;

        for (countI = 0; countI < i; countI++) {
            for (countJ = 0; countJ < j; countJ++) {
                cin >> mArray[countI][countJ];
            }
        }

        for (countI = 0; countI < i; countI++) {
            for (countJ = 0; countJ < j; countJ++) {
                sum += mArray[countI][countJ];
            }
            cout << "Сумма " << countI + 1 << " строки: " << sum << endl;;
            sum = 0;
        }
        break;

    case 8:
        cout << "Введите размер массива" << endl;;
        cin >> i >> j;

        for (countI = 0; countI < i; countI++) {
            for (countJ = 0; countJ < j; countJ++) {
                cin >> mArray[countI][countJ];
                sum += mArray[countI][countJ];
            }
        }
        cout << "Среднее арифмитическое всех элементов равно: " << sum / (i * j);
        break;

    case 9:
        cout << "Введите элементы матрицы" << endl;
        for (countI = 0; countI < 2; countI++) {
            for (countJ = 0; countJ < 2; countJ++) {
                cin >> mArray[countI][countJ];
            }
        }
        matrix = mArray[0][0] * mArray[1][1] - mArray[0][1] * mArray[1][0];
        cout << "Определитель матрицы равен: " << matrix;
        break;
    case 10:
        for (countI = 0; countI < 5; countI++) {
            for (countJ = 0; countJ < 5; countJ++) {
                mArray[countI][countJ] = rand() % 10;
            }
        }
        cout << endl;
        for (countI = 0; countI < 5; countI++) {
            array[countI] = 0;
            for (countJ = 0; countJ < 5; countJ++) {
                array[countI] += mArray[countI][countJ];
                cout << mArray[countI][countJ] << " ";
            }
            cout << endl;
        }
        cout << endl;
        for (count = 0; count < 5; count++) {
            cout << "Сумма элементов " << count + 1 << " строки равна: " << array[count] << endl;
            
            if (array[count] > max) {
                max = array[count];
                maxStr = count;
            }
        }
        
        cout << "\n" << "Номер строки с максимальной суммой: " << maxStr + 1 << "\n" << "Сумма строки: " << max << endl;
        break;
    }




    cout << endl;
    system("pause");
}

