# Nrrdio.Ynab

This is an incomplete manual implementation of the [YNAB API v1](https://api.youneedabudget.com/v1). One day I will remove the word "incomplete" from that sentence.

## Why not use Swagger like they recommend?

* Just to prove to myself I can.
* Because I like the latest C# features.
* Because I like completely unencumbered code and want to unlicense this. <sup>1</sup>

## Why not use other YNAB libraries?

* I only found one, and it was missing tests.
* Because it seems like everyone encumbers code with licenses these days, and I don't care if people give me attribution.

---

1: The Macross library is unfortunately encumbered by [the MIT license](https://github.com/Macross-Software/core/blob/develop/LICENSE.txt), but is necessary due to a bug in how the System.Text.Json library implements enum deserialization. Eventually it will be removed.
