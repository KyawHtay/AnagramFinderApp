# AnagramFinderApp

What are anagrams?

Anagrams are words formed by rearranging the letters of a different word.

For example "silent" and "listen" or "binary" and "brainy" are anagram pairs.



Description

C# which is able to search in attached file (words.txt) and find the largest set of words (maximum number of occurrences) contained inside that are anagrams of each other.



Example

If "words.txt" was containing following words:

binary

please

asleep

brainy

sapele



"binary" and "brainy" are anagrams (2 occurrences)

"please", "asleep" and "sapele" are anagrams (3 occurrences) -> It should return this list


On top of finding the largest set of anagrams, 

- A count of words for each letter prefixed with that character from A-Z.

- It finds the word with the largest number of distinct characters.





### Single Responsibility Principle (SRP):

This principle states that a class should have only one reason to change, meaning it should have only one responsibility or job. If a class has multiple responsibilities, changes to one may affect the others, leading to maintenance issues and making the class harder to understand.
Example: In the context of the **AnagramFinder**, the **AnagramSolver** class should be responsible for solving anagrams and related tasks, such as counting letters and finding words with the most distinct characters. It should not be responsible for handling file I/O operations or user interface interactions. These concerns should be delegated to other classes.

### Open/Closed Principle (OCP):

This principle states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. In other words, you should be able to extend the behavior of a class without modifying its source code.
Example: In the AnagramFinder, if you want to add a new way of calculating anagrams (e.g., using a different algorithm), you should be able to do so by creating a new class that implements the anagram-solving interface without modifying the existing AnagramSolver class.

### Liskov Substitution Principle (LSP):

This principle states that objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program. In other words, a subclass should be able to replace its superclass without causing unexpected behavior.
Example: If you have a class hierarchy for different types of anagram solvers (e.g., one that uses a dictionary and another that uses a brute-force approach), you should be able to use any subclass interchangeably with the superclass AnagramSolver without breaking the program.

### Interface Segregation Principle (ISP):

This principle states that clients should not be forced to depend on interfaces they do not use. It suggests breaking interfaces into smaller, more specific ones so that clients only need to know about the methods that are relevant to them.
Example: In the AnagramFinder, instead of having a single interface that contains methods for solving anagrams, counting letters, and finding words with distinct characters, you could have separate interfaces for each of these tasks. This way, clients can depend on only the interfaces they need.

### Dependency Inversion Principle (DIP):

This principle states that high-level modules should not depend on low-level modules; both should depend on abstractions. It also suggests that abstractions should not depend on details; details should depend on abstractions.
Example: In the AnagramFinder, instead of directly depending on concrete implementations of file I/O operations or other external services, the AnagramSolver class should depend on abstractions (e.g., interfaces or abstract classes) that define the operations it needs. This allows for easier testing, swapping out implementations, and better separation of concerns.



