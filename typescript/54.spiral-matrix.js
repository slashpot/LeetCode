/*
 * @lc app=leetcode id=54 lang=javascript
 *
 * [54] Spiral Matrix
 */

// @lc code=start
/**
 * @param {number[][]} matrix
 * @return {number[]}
 */
 var spiralOrder = function(matrix) {
   
    // const output = [];
    // while (matrix[0]) {
        
    // }
    const xLength = matrix.length;
    const yLength = matrix[0].length;
    const nums = xLength * yLength;
    let x = 0;
    let y = yLength - 1;

    const directions = [[1,0],[0,-1],[-1,0],[0,1]];
    let currentDirection = 0;

    const output = [...matrix[0]];
    matrix[0] = [];

    while (output.length != nums) {
        let nextPos
        while (true) {
            nextPos = [x+directions[currentDirection][0], y+directions[currentDirection][1]];
            if (nextPos[0] >= 0 && nextPos[1]>=0 && nextPos[0] < xLength && nextPos[1] < yLength && matrix[nextPos[0]][nextPos[1]] !== undefined &&matrix[nextPos[0]][nextPos[1]] !== null ) {
                break;
            }
            currentDirection ++;
            if (currentDirection === directions.length) {
                currentDirection = 0;
            }
        }
        // console.log(matrix)
        // console.log(nextPos);
        output.push(matrix[nextPos[0]][nextPos[1]]);
        x = nextPos[0], y=nextPos[1];
        matrix[nextPos[0]][nextPos[1]] = null;
    }
    return output;
};
// @lc code=end

spiralOrder([[2,5],[8,4],[0,-1]]);