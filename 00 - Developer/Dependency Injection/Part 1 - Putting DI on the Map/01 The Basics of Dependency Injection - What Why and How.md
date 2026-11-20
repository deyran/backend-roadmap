You may have heard that making a sauce béarnaise is difficult. Even among people
who regularly cook, many have never attempted to make one. This is a shame,
because the sauce is delicious. (It’s traditionally paired with steak, but it’s also an
excellent accompaniment to white asparagus, poached eggs, and other dishes.)
Some resort to substitutes like ready-made sauces or instant mixes, but these aren’t
nearly as satisfying as the real thing.

A sauce béarnaise is an emulsified sauce made from egg yolk and butter, that’s
flavored with tarragon, chervil, shallots, and vinegar. It contains no water. The biggest
challenge to making it is that its preparation can fail. The sauce can curdle or
separate, and, if either happens, you can’t resurrect it. It takes about 45 minutes to
prepare, so a failed attempt means that you may not have time for a second try. On the other hand, any chef can prepare a sauce béarnaise. It’s part of their training and, as
they’ll tell you, it’s not difficult.

---

You don’t have to be a professional cook to make sauce béarnaise. Anyone learning
to make it will fail at least once, but after you get the hang of it, you’ll succeed every
time. We think Dependency Injection (DI) is like sauce béarnaise. It’s assumed to be difficult,
and, if you try to use it and fail, it’s likely there won’t be time for a second attempt.

**DEFINITION** Dependency Injection is a set of software design principles and patterns
that enables you to develop loosely coupled code.

Despite the fear, uncertainty, and doubt (FUD) surrounding DI, it’s as easy to learn
as making a sauce béarnaise. You may make mistakes while you learn, but once you’ve
mastered the technique, you’ll never again fail to apply it successfully.

Stack Overflow, the software development Q&A website, features an answer to the
question, “How to explain Dependency Injection to a 5-year old?” The most highly
rated answer, by John Munsch, provides a surprisingly accurate analogy targeted at the
(imaginary) five-year-old inquisitor: 

	When you go and get things out of the refrigerator for yourself, you can cause problems. You might leave the door open, you might get something Mommy or Daddy doesn’t want you to have. You might even be looking for something we don’t even have or which has expired. What you should be doing is stating a need, “I need something to drink with lunch,” and then we will make sure you have something when you sit down to eat.

What this means in terms of object-oriented software development is this: collaborating
classes (the five-year-old) should rely on infrastructure (the parents) to provide
necessary services.

NOTE In DI terminology, we often talk about services and components. A service
is typically an Abstraction, a definition for something that provides a service.
An implementation of an Abstraction is often called a component, a class that
contains behavior. Because both service and component are such overloaded terms,
throughout this book, you’ll typically see us use the terms “Abstraction” and
“class” instead.

This chapter is fairly linear in structure. First, we introduce DI, including its purpose
and benefits. Although we include examples, overall, this chapter has less code than
any other chapter in the book. Before we introduce DI, we discuss the basic purpose
of DI — maintainability. This is important because it’s easy to misunderstand DI if you
aren’t properly prepared. Next, after an example (Hello DI!), we discuss benefits and
scope, laying out a road map for the book. When you’re done with this chapter, you
should be prepared for the more advanced concepts in the rest of the book.

To most developers, DI may seem like a rather backward way of creating source code,
and, like sauce béarnaise, there’s much FUD involved. To learn about DI, you must first
understand its purpose.
