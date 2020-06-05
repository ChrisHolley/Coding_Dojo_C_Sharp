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

    printList() {
        if(this.head == null) {
            console.log("The list is empty.");
            return this;
        }
        let str = "H: ";
        let runner = this.head;
        while(runner != null) {
            str += `${runner.value} -> `
            runner = runner.next;
        }
        console.log(str);
        return this;
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
        runner = this.head.next;
        walker = this.head;
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

myList.printList();

console.log(myList.moveMinFront());


myList.printList();