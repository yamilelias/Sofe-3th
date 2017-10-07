package sofe.exercise1;

import java.util.Arrays;

public class ContinuousArray {

    static int auxiliar = 0;
    static int cont = 0;

    public static void main(String[] args) {
        int array[] = {1, 3, 2, 4, 1};
        isAlmostIncreasingSequence(array);

    }

    public static boolean isAlmostIncreasingSequence(int[] sequence) {
//        int elements_deleted = 0;
//
//        for (int i = 0; i < sequence.length; i++) {
//            for (int j = i+1; j < sequence.length; j++) {
//                              
//                if(!checkArray(Arrays.copyOfRange(sequence, i, j))){
//                    elements_deleted++;
//                }
//                
//                if(elements_deleted == 2){
//                        return false;
//                }
//            }
//        }
//        return true;
        recursivityMethod(sequence);
        if (cont > 1) {
            return false;
        }
        return true;
    }

    public static void recursivityMethod(int[] sequence) {
        for (int i = 1; i < sequence.length; i++) {
            if (!(sequence[i] > sequence[i - 1])) {
                if (i == 0 || i == sequence.length-1) {
                    cont ++;
                    
                }
                else if (sequence[i - 1] < sequence[i + 1]) {
                    cont++;

                    // COPIA DEL ARREGLO SIN UN ELEMENTO
                    int arrayAux1[] = Arrays.copyOfRange(sequence, 0, i - 1);
                    int arrayAux2[] = Arrays.copyOfRange(sequence, i + 1, sequence.length - 1);

                    // Concatenate
                    int array[] = new int[arrayAux1.length + arrayAux2.length];
                    System.arraycopy(arrayAux1, 0, array, 0, arrayAux1.length);
                    System.arraycopy(arrayAux2, 0, array, arrayAux1.length, arrayAux2.length);

//                        for (int j = 0; j < sequence.length-1; j++) {
//                            if (j < i) {
//                                array[j] = Arrays.co
//                            } else {
//                                array[j] = sequence[j + 1];
//                            }
//                        }
                    recursivityMethod(array);
                }

            }
        }
        
    }

    public static boolean checkArray(int[] array) {
        for (int i = 1; i < array.length; i++) {
            if (array[i] == auxiliar) {
                return false;
            }
            if (array[i - 1] > array[i]) {
                auxiliar = array[i];
                return false;
            }
        }
        return true;
    }

}
