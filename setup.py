import setuptools


with open("README.md", "r") as fh:
    long_description = fh.read()

REQUIREMENTS = [
    "easypost",
]

DEV_REQUIREMENTS = [
    "black",
    "flake8",
    "isort",
]

setuptools.setup(
    name="examples",
    version="0.1.0",
    description="This repository holds hundreds of code examples for using the EasyPost API across 7+ programming languages.",  # noqa
    long_description=long_description,
    long_description_content_type="text/markdown",
    url="http://github.com/EasyPost/examples",
    author="EasyPost",
    license="MIT",
    packages=setuptools.find_packages(),
    classifiers=[
        "Programming Language :: Python :: 3",
        "License :: OSI Approved :: MIT License",
        "Operating System :: OS Independent",
    ],
    install_requires=REQUIREMENTS,
    extras_require={
        "dev": DEV_REQUIREMENTS,
    },
    python_requires=">=3.6, <4",
)
