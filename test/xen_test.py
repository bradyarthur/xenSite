import pytest
import mymodule

def func(x):
    return x + 1

def test_answer():
    assert func(3) == 4

def test_product():
    result = mymodule.product(1, 2, 3)
    assert result==6

# test_product()    
    



    