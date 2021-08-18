// let data = 42;
//& let data number | string = 42;
//! Number cannot be string:
////data = '43'; 
//Duck Typing ->Guess type

//Interface: //! Don't use I in Type
export interface Duck {
    name: string;
    numLegs: number;
    makeSound: (sound: string) => void; //*Make Sound optional with
}

const duckOne:Duck = {
    name: 'Huey',
    numLegs:  2,
    ////MakeSound: (sound) => console.log(sound)
    //! Cannot implicitly have any type 
    makeSound: (sound: any) => console.log(sound)
}

const duckTwo:Duck = {
    name: 'Dewey',
    numLegs:  2,
    makeSound: (sound) => console.log(sound)
}

const duckThree:Duck = {
    name: 'Huey',
    numLegs:  4,
    makeSound: (sound) => console.log(sound)
}

//duckOne.name = 1; 
//!Cannot Assign to string

duckOne.name = 'Loewi';
////duckTwo.makeSound('Test')
//!Cannot without overriding

//duckTwo.makeSound!('Quack') 
//*I know better -Not recommended

export const ducks = [duckOne, duckTwo, duckThree];

