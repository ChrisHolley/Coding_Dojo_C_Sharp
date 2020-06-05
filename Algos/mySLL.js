// This is the class for our Singly Linked Node
class SLNode {
    // The constructor is built to take 1 parameter, being the value of the node we want
    // to create
    constructor(val) {
        // This is the node's actual value
        this.value = val;
        // And this indicates what is next after the current node.
        this.next = null;
    }
}

class SLList {
    constructor() {
        // This is the beginning of the singly linked list
        this.head = null;
    }


    // Write a method that will return a boolean depending on whether or not the singly
    // linked list is empty or not.
    isEmpty() {
        if (this.head === null) {
            return true;
        }
        else {
            return false;
        }
    }

    // Write a method that is given a value, and adds a new node to the end of a SLL
    // where that new node has that value.
    addToBack(value) {
        var runner = this.head;
        while (runner.next !== null) {
            runner = runner.next;

        }
        runner.next = new SLNode(value);
        return this;

    }




    // Write a method that prints the contents of a Singly Linked List.
    printList() {
        // Let's start a runner at the beginning of the singly linked list itself
        var runner = this.head;
        // This string will be added to as we traverse along the SLL
        var string = "";


        // Now we need a way to traverse through the SLL

        // If the runner is not null, we're still looking at a node, so we have things to do!
        while(runner != null) {
            // We want to add the node's value to our string, and a fancy little arrow for looks
            string += runner.value + " -> ";
            // Then, we want to progress the runner to the NEXT node in the SLL
            runner = runner.next;
        }
        
        // Once we've finished moving through the entire list, we want to print the string
        console.log(string);
    }
    addToFront(value){
        var newFront = new SLNode(value);
        newFront.next = this.head;
        this.head = newFront;
        return this;
        
    }
    removeFromFront(){
        this.head = this.head.next;
        return this;
    }

    contains(value) {
        let runner = this.head;
        if (runner.value === value){
            return true;
        }
        if (runner.next === null){
            return false;
        }
        else {
            runner = runner.next;
        }
    }



    moveMinFront(){
        let runner = this.head.next;
        let min = this.head.value
        while (runner != null){
            if (runner.value < min){
                min = runner.value;
            }
            runner = runner.next;

        }
        console.log(runner)
        runner = this.head.next;
        console.log(runner)
        let walker = this.head;
        while(runner.value != min.value){
            runner = runner.next;
            walker = walker.next;
        }
        walker.next = runner.next;
        runner.next = this.head.next;
        this.head = runner;
    }
    removeVal(value){

    }

}

var myList = new SLList();
myList.head = new SLNode(5);
myList.head.next = new SLNode(6);
myList.head.next.next = new SLNode(7);
myList.addToBack(99).addToBack(12);
myList.addToFront(25).addToFront(45);
myList.addToFront(333);
myList.removeFromFront();
myList.printList();
console.log(myList.contains(333));
console.log(myList.moveMinFront());

myList.printList();