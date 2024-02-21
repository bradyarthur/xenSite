import functools

def product(*numbers: float) -> float:
    return functools.reduce(lambda x, y: x*y, numbers)