function isHappy(n: number): boolean {
    const memoriedSet = new Set();
    let current = n;
    while(!memoriedSet.has(current)) {
        memoriedSet.add(current);
        const divided = current.toString().split('');
        let sum = 0;
        divided.forEach(x=>{
            sum += Math.pow(Number(x),2);
        });
        if(sum === 1) return true;
        current = sum;
    }
    return false;
};
