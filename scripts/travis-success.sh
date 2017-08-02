#!/bin/bash
echo Executing after success scripts on branch $TRAVIS_BRANCH
echo Publishing application
./scripts/publish.sh