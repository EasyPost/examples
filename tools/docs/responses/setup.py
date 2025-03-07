from setuptools import (
    find_packages,
    setup,
)


REQUIREMENTS = [
    "easypost==7.*",
    "python-dotenv",
]

DEV_REQUIREMENTS = [
    "black==22.*",
    "flake8==5.*",
    "isort==5.*",
    "pytest-vcr==1.*",
    "pytest==7.*",
    "vcrpy==4.*",
]

with open("README.md", encoding="utf-8") as f:
    long_description = f.read()

setup(
    name="easypost_responses",
    version="0.1.0",
    description="",
    author="EasyPost",
    author_email="support@easypost.com",
    url="https://easypost.com/",
    packages=find_packages(
        exclude=[
            "examples",
            "tests",
        ]
    ),
    install_requires=REQUIREMENTS,
    extras_require={
        "dev": DEV_REQUIREMENTS,
    },
    test_suite="test",
    long_description=long_description,
    long_description_content_type="text/markdown",
    python_requires=">=3.6, <4",
)
