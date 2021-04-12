export interface Ad {
    Title: string;
    Description: string;
    Author: string;
    ISBN: string;
    College: string;
    Rate: Number;
    ImagePath: string;
}

export interface AdList {
    author: string;
    college: string;
    description: string;
    id: Number;
    imageFile: string;
    imagePath: string;
    isbn: string
    rate: Number
    title: Number
    userId: string
}